
using System;
using System.Collections;
using System.Collections.Generic;

namespace RewardBoxManager.Models
{
        
          
    public class FMasterRewardBoxItem
    {
        /// <summary>
        /// 보상 박스 아이템 아이디
        /// </summary>
        public int reward_box_item_id { get; set; } = 0;
            
        /// <summary>
        /// 보상 박스 아이디
        /// </summary>
        public int reward_box_id { get; set; } = 0;
            
        /// <summary>
        /// 아이템 코드
        /// </summary>
        public string item_code { get; set; } = string.Empty;
            
        /// <summary>
        /// 아이템 x 위치
        /// </summary>
        public int x { get; set; } = 0;
            
        /// <summary>
        /// 아이템 y 위치
        /// </summary>
        public int y { get; set; } = 0;
            
        /// <summary>
        /// 아이템 회전
        /// </summary>
        public int rotation { get; set; } = 0;
            
        /// <summary>
        /// 아이템 수량
        /// </summary>
        public int amount { get; set; } = 0;
            
    }

}