using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEST
{
    public sealed class ArtCollecetionMap : CsvClassMap<ArtCollecetion>
    {
        public ArtCollecetionMap()
        {
            //Map(m => m.Id).Index(0);
            Map(m => m.Id).Name("고유번호"); 
            Map(m => m.CategoryCode).Name("작품분류코드");
            Map(m => m.CategoryName).Name("작품분류명");
            Map(m => m.ManagedYear).Name("관리번호(년도)");
            Map(m => m.ManagedNumber).Name("관리번호(번호)");
            Map(m => m.TitleKorean).Name("작품명(국문)");
            Map(m => m.TitleEnglish).Name("작품명(영문)");
            Map(m => m.Size).Name("작품규격");
            Map(m => m.FrameSize).Name("액자규격");
            Map(m => m.ProductionYear).Name("제작년도");
            Map(m => m.Material).Name("재료/기법");
            Map(m => m.Donor).Name("기증자");
            Map(m => m.CollectionYear).Name("수집년도");
            Map(m => m.CollectionCategoryCode).Name("소장처분류코드");
            Map(m => m.CollectionCategoryName).Name("소장처분류명");
            Map(m => m.Caption).Name("작품캡션");
            Map(m => m.Artist).Name("작가명");
            Map(m => m.MainImageUrl).Name("메인이미지");
            Map(m => m.ThumbnailImageUrl).Name("썸네일이미지");
        }
    }
}
