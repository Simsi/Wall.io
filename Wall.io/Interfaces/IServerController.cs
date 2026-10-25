using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall.io.Interfaces
{
    internal interface IServerController
    {
        public abstract bool InvalidateUserLogin(string username, string password);
        /// <summary>
        ///  Подключение к серверу
        /// </summary>
        /// <returns></returns>
        public abstract bool Connect();

        /// <summary>
        /// Отключение от сервера
        /// </summary>
        /// <returns></returns>
        public abstract bool Disconnect();

        /// <summary>
        /// Проверка наличие подключения к текущему серверу
        /// </summary>
        /// <returns></returns>
        public abstract bool IsConnected();

    }
}
