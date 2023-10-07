using HT_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N44_HT_1;

public class Delayedd
{

    public async ValueTask<string> GetFullname(CancellationToken cancellationToken, User user)
    {
        await Task.Delay(6000);
        if (cancellationToken.IsCancellationRequested)
        {
            Console.WriteLine("Getting fullname is canceled");
            return null;
        }
        return await Task.Run(() => { return $"{user.FirstName} {user.LastName}"; });
    }
}
