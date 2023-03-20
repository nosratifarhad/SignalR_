using SignalR.HubService.Dtos.OnlineUserHubDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableDependency.SqlClient.Base.EventArgs;

namespace SignalR.HubService.SqlTableDependencyConfig
{
    public class NotificationEventArgs : EventArgs
    {
        public RecordChangedEventArgs<OnlineUserHubDto> ChatServerArgs { get; private set; }

        public NotificationEventArgs(RecordChangedEventArgs<OnlineUserHubDto> chatServerArgs)
        {
            this.ChatServerArgs = chatServerArgs;
        }
    }
    public delegate void NotificationEventHandler(OnlineUserHubDto chatServer, NotificationEventArgs e);

}
