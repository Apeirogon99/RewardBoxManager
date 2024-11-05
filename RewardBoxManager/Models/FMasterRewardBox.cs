
using System;
using System.Collections;
using System.Collections.Generic;

namespace RewardBoxManager.Models
{
        
          
    public class FMasterRewardBox
    {
        /// <summary>
        /// 보상 박스 아이디
        /// </summary>
        public int reward_box_id { get; set; } = 0;

        /// <summary>
        /// 박스 이름
        /// </summary>
        public int name { get; set; } = 0;

        /// <summary>
        /// 박스 x크기
        /// </summary>
        public int scale_x { get; set; } = 0;
            
        /// <summary>
        /// 박스 y크기
        /// </summary>
        public int scale_y { get; set; } = 0;
            
    }

}