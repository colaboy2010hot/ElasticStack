using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEST
{
    // 서울시립 박물관 소장품 (http://data.seoul.go.kr/openinf/sheetview.jsp?infId=OA-13498)
    [Nest.ElasticsearchType(Name = "artcollecetion")]
    public class ArtCollecetion
    {
        /// <summary>
        /// 고유번호
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 작품분류코드
        /// </summary>
        public String CategoryCode { get; set; }

        /// <summary>
        /// 작품분류명
        /// </summary>
        public String CategoryName { get; set; }

        /// <summary>
        /// 관리번호(년도)
        /// </summary>
        public int ManagedYear { get; set; }

        /// <summary>
        /// 관리번호(번호)
        /// </summary>
        public int ManagedNumber { get; set; }

        /// <summary>
        /// 작품명(국문)
        /// </summary>
        [Text(Name = "titleKorean")]
        public string TitleKorean { get; set; }

        /// <summary>
        /// 작품명(영문)
        /// </summary>
        public string TitleEnglish { get; set; }

        /// <summary>
        /// 작품규격
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// 액자규격
        /// </summary>
        public String FrameSize { get; set; }

        /// <summary>
        /// 제작년도
        /// </summary>
        public string ProductionYear { get; set; }

        /// <summary>
        /// 재료/기법
        /// </summary>
        public string Material { get; set; }

        /// <summary>
        /// 기증자
        /// </summary>
        public string Donor { get; set; }

        /// <summary>
        /// 수집년도
        /// </summary>
        public int CollectionYear { get; set; }

        /// <summary>
        /// 소장처분류코드
        /// </summary>
        public string CollectionCategoryCode { get; set; }

        /// <summary>
        /// 소장처분류명
        /// </summary>
        public string CollectionCategoryName { get; set; }

        /// <summary>
        /// 작품캡션
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// 작가명
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// 메인이미지
        /// </summary>
        public string MainImageUrl { get; set; }

        /// <summary>
        /// 썸네일이미지
        /// </summary>
        public string ThumbnailImageUrl { get; set; }
    }
}
