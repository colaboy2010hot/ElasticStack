using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEST
{
    // 서울시 외국어 표기 정보 (http://data.seoul.go.kr/openinf/sheetview.jsp?infId=OA-2475&tMenu=11)
    public class ForeignLanguage
    {
        /// <summary>
        /// 일련번호
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 카테고리
        /// </summary>
        public String CategoryCode { get; set; }

        /// <summary>
        /// 카테고리명
        /// </summary>
        public String CategoryName { get; set; }

        /// <summary>
        /// 한글
        /// </summary>
        public String Korean { get; set; }

        /// <summary>
        /// 영문
        /// </summary>
        public String English { get; set; }

        /// <summary>
        /// 중문(간체)
        /// </summary>
        public String SimplifiedChinese { get; set; }

        /// <summary>
        /// 중문(번체)
        /// </summary>
        public String TraditionalChinese { get; set; }

        /// <summary>
        /// 일문
        /// </summary>
        public String Japanese { get; set; }

        /// <summary>
        /// 비고
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        /// 출처
        /// </summary>
        public String Source { get; set; }

        /// <summary>
        /// 등록일
        /// </summary>
        public DateTime RegistrationDate { get; set; }
    }
}
