using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wall.io.Interfaces;
using Wall.io.StructuresAndDataClasses;

namespace Wall.io.Controllers
{
    internal class ServerController : IServerController
    {

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////Свойства и поля///////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private ServerState serverState;

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////Конструкторы////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public ServerController() 
        {
            serverState = new();

            serverState.PropertyChanged += ServerState_PropertyChanged;
        }


        /// <summary>
        /// Для прокидывания ServerState наружу в AppController
        /// </summary>
        /// <param name="servState"></param>
        public ServerController(ServerState servState)
        {
            serverState = servState;
            if (Connect())
            {
                serverState.IsConnected = true;
            }
            else
            {
                int ctr = 0;
                while (ctr < serverState.ConnectionRetries)
                {
                    if (!Connect())
                    {
                        ctr++;
                    }
                    else
                    {
                        serverState.IsConnected = true;
                        break;
                    }
                }
            }
                servState.PropertyChanged += ServerState_PropertyChanged;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////Методы///////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Connect()
        {
            // TODO
            return true;
        }

        public bool Disconnect()
        {
            // TODO
            return true;
        }

        public bool InvalidateUserLogin(string username, string password)
        {
            // TODO
            if (username == "admin" && password == "admin")
            {
                serverState.AuthOK = true;
                return true;
            }
            return false;
        }

        public bool IsConnected()
        {
            // TODO
            return true;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////Обработчики событий/////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ServerState_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
           // throw new NotImplementedException();
        }
    }
}
