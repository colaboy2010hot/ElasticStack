using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NEST
{
    public sealed class ForeignLanguageMap : CsvClassMap<ForeignLanguage>
    {
        public ForeignLanguageMap()
        {
            Map(m => m.CategoryCode).Name("카테고리");
            Map(m => m.CategoryName).Name("카테고리명");
            Map(m => m.Id).Name("일련번호");
            Map(m => m.Korean).Name("한글");
            Map(m => m.English).Name("영문");
            Map(m => m.SimplifiedChinese).Name("중문(간체)");
            Map(m => m.TraditionalChinese).Name("중문(번체)");
            Map(m => m.Japanese).Name("일문");
            Map(m => m.Remark).Name("비고");
            Map(m => m.Source).Name("출처");
            Map(m => m.RegistrationDate).Name("등록일");
        }
    }
}