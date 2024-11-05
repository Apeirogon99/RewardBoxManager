using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewardBoxManager.Models
{
    public class FMasterRewardBase
    {
        /// <summary>
        /// 보상 아이디
        /// </summary>
        public int reward_id { get; set; } = 0;

        /// <summary>
        /// 돈
        /// </summary>
        public int money { get; set; } = 0;

        /// <summary>
        /// 티켓
        /// </summary>
        public int ticket { get; set; } = 0;

        /// <summary>
        /// 가챠
        /// </summary>
        public int gacha { get; set; } = 0;

        /// <summary>
        /// 경험치
        /// </summary>
        public int experience { get; set; } = 0;

        /// <summary>
        /// 보상 박스 아이디
        /// </summary>
        public int? reward_box_id { get; set; } = null;

    }
}
