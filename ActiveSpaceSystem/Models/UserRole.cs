using System;
using System.Collections.Generic;

namespace ActiveSpace.Models
{
    // 1. نظام الأدوار والمستخدمين (بديل الموظفين)
    public enum UserRole { Admin, Staff }
    public enum MonthlyContractDay { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday }
    public enum MonthlyContractStatus { Active, Expired, Cancelled }
}