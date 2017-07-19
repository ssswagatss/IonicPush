using IonicPush.CSharp.Models;
using IonicPush.CSharp.Models.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IonicPush.CSharp.Interfaces
{
    public interface  IToken
    {
        /// <summary>
        /// Retrives Device Tokens saved in ionic cloud
        /// </summary>
        /// <param name="showInvalid">Determines whether to include invalidated tokens</param>
        /// <param name="pageSize">Sets the number of items to return in paginated endpoints.</param>
        /// <param name="page">Sets the page number for paginated endpoints</param>
        /// <param name="userId">Only display tokens associated with the User ID. (UUID)</param>
        /// <returns></returns>
        Task<Result<List<DeviceTokenVM>>> GetTokens(bool? showInvalid, int? pageSize, int? page, string userId = "");
    }
}
