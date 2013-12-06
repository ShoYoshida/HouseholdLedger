using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseholdLedger.Common
{
    public static class CodeConversion
    {
        public static readonly string[] types = {
                                                    "食費",
                                                    "交際費",
                                                    "日用品",
                                                    "備品家具",
                                                    "家賃",
                                                    "電気代",
                                                    "ガス代",
                                                    "水道代",
                                                    "電話代",
                                                    "携帯代",
                                                    "交通費",
                                                    "教育費",
                                                    "保険料",
                                                    "衣類",
                                                    "医療費",
                                                    "その他"};

        public static string CnvType(int i)
        {
            return types[i];            
        }


    }
}