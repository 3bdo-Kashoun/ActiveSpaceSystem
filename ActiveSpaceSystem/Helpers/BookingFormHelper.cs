using ActiveSpace.Models;
using ActiveSpaceSystem.Data;
using System;
using System.Linq;

namespace ActiveSpaceSystem.Helpers
{
    public static class BookingFormHelper
    {
        // دالة مخصصة للتحقق من أن وقت الحجز لم يفت بالفعل مقارنة باللحظة الحالية
        public static bool IsDateTimeInPast(DateTime date, TimeSpan start, out string warningMessage)
        {
            warningMessage = string.Empty;
            DateTime now = DateTime.Now;

            // 1. إذا كان التاريخ المختار بالكامل قبل تاريخ اليوم الفعلي
            if (date.Date < now.Date)
            {
                warningMessage = "لا يمكن حجز موعد في تاريخ قد مضى. يرجى اختيار تاريخ اليوم أو تاريخ مستقبلي.";
                return true;
            }

            // 2. إذا كان الحجز في نفس اليوم، نتحقق من أن وقت البداية لم يمر بعد مقارنة بالوقت الحالي
            if (date.Date == now.Date)
            {
                // دمج تاريخ اليوم مع وقت بداية الحجز للمقارنة الدقيقة بالثانية والدقيقة
                DateTime bookingStartDateTime = date.Date.Add(start);

                if (bookingStartDateTime < now)
                {
                    string currentTimeStr = now.ToString(@"HH:mm");
                    warningMessage = $"الوقت المختار قد مضى! نحن الآن في الساعة {currentTimeStr}. يرجى اختيار وقت مستقبلي.";
                    return true;
                }
            }

            return false;
        }

        // التحقق الشامل (الأوقات الفائتة، أوقات العمل الرسمية، وتداخل الحجوزات)
        public static bool IsCourtReserved(Court court, DateTime date, TimeSpan start, TimeSpan end, out string warningMessage)
        {
            warningMessage = string.Empty;

            // 1. التحقق من صحة مدخلات الوقت الأساسية
            if (start >= end)
            {
                warningMessage = "تنبيه: وقت بداية الحجز يجب أن يكون قبل وقت النهاية.";
                return true;
            }

            // 2. التحقق من أن الوقت والتاريخ المطلوبين لم يمضيا بالفعل
            if (IsDateTimeInPast(date, start, out string pastWarning))
            {
                warningMessage = pastWarning;
                return true;
            }

            // 3. معالجة أوقات فتح وإغلاق الملعب (ودعم الإغلاق عند منتصف الليل أو بعده)
            TimeSpan courtOpen = court.OpenTime;
            TimeSpan courtClose = court.CloseTime;

            if (courtClose <= courtOpen)
            {
                courtClose = courtClose.Add(TimeSpan.FromHours(24));
            }

            TimeSpan adjustedEnd = end;
            if (adjustedEnd <= start)
            {
                adjustedEnd = adjustedEnd.Add(TimeSpan.FromHours(24));
            }

            // 4. التحقق من أن الوقت المطلوب يقع بالكامل داخل ساعات عمل الملعب
            if (start < courtOpen || adjustedEnd > courtClose)
            {
                string openStr = court.OpenTime.ToString(@"hh\:mm");
                string closeStr = court.CloseTime.ToString(@"hh\:mm");

                warningMessage = $"خارج أوقات العمل! هذا الملعب ({court.CourtName}) " +
                                 $"يستقبل الحجوزات فقط من الساعة {openStr} صباحاً حتى الساعة {closeStr} مساءً.";
                return true;
            }

            // 5. التحقق من تداخل الوقت مع حجز قائم في القائمة
            bool isReserved = DataStorage.BookingsList.Any(b =>
                b.CourtID == court.CourtID &&
                b.BookingDate.Date == date.Date &&
                start < b.EndTime &&
                end > b.StartTime
            );

            if (isReserved)
            {
                warningMessage = "هذا الملعب محجوز بالفعل في الفترة الزمنية المحددة. الرجاء اختيار وقت آخر.";
            }

            return isReserved;
        }

        // التحقق من منطقية القيم المالية (العربون والإجمالي)
        public static bool TryValidateFinancials(double totalAmount, double deposit, out string warningMessage)
        {
            warningMessage = string.Empty;

            if (deposit <= 0)
            {
                warningMessage = "قيمة العربون غير مقبولة، يجب دفع قيمة أكبر من الصفر لتأكيد الحجز.";
                return false;
            }

            if (deposit > totalAmount)
            {
                warningMessage = "لا يمكن أن تكون قيمة العربون أكبر من قيمة المبلغ الإجمالي للحجز.";
                return false;
            }

            return true;
        }
    }
}