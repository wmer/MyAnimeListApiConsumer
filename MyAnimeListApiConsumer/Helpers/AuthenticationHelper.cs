using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnimeListApiConsumer.Helpers {
    public class AuthenticationHelper {
        public static String ConvertToBase64(string username, string password) {
            var credentialsToBytes = Encoding.UTF8.GetBytes($"{username}:{password}");
            return Convert.ToBase64String(credentialsToBytes);
        }
    }
}
