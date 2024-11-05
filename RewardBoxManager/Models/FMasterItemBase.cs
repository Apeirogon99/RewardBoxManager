using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewardBoxManager.Models
{
    /// <summary>
    /// 아이템 타입
    /// </summary>
    public enum EItemType
    {
        None,       // NONE
        Weapon,     // 무기
        Defensive,  // 방어구
        Bag,        // 가방
        Recovery,   // 회복
        Bullet,     // 총알
        Spoil,      // 자원
    }

    public class FMasterItemBase
    {
        /// <summary>
        /// 아이템 아이디
        /// </summary>
        public int item_id { get; set; } = 0;

        /// <summary>
        /// 아이템 코드
        /// </summary>
        public string code { get; set; } = string.Empty;

        /// <summary>
        /// 아이템 이름
        /// </summary>
        public string name { get; set; } = string.Empty;

        /// <summary>
        /// 아이템 무게
        /// </summary>
        public double weight { get; set; } = 0;

        /// <summary>
        /// 아이템 타입
        /// </summary>
        public string type { get; set; } = string.Empty;

        /// <summary>
        /// 아이템 설명
        /// </summary>
        public int description { get; set; } = 0;

        /// <summary>
        /// 아이템 가로 크기
        /// </summary>
        public int scale_x { get; set; } = 0;

        /// <summary>
        /// 아이템 세로 크기
        /// </summary>
        public int scale_y { get; set; } = 0;

        /// <summary>
        /// 아이템 구매 가격
        /// </summary>
        public int purchase_price { get; set; } = 0;

        /// <summary>
        /// 아이템 조회 시간
        /// </summary>
        public double inquiry_time { get; set; } = 0;

        /// <summary>
        /// 아이템 판매 가격
        /// </summary>
        public int sell_price { get; set; } = 0;

        /// <summary>
        /// 수량
        /// </summary>
        public int amount { get; set; } = 0;

        /// <summary>
        /// 아이템 아이콘 경로
        /// </summary>
        public string icon { get; set; } = string.Empty;

    }
}
