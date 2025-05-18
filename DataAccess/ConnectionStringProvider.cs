using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ConnectionStringProvider
    {
        // Лениво инициализируемый потокобезопасный Singleton
        private static readonly Lazy<ConnectionStringProvider>
            _instance = new Lazy<ConnectionStringProvider>(
                () => new ConnectionStringProvider());

        // Строка подключения
        public string ConnectionString { get; }

        // Приватный конструктор
        private ConnectionStringProvider()
        {
            ConnectionString = "Host=localhost;Database=postgres;Username=postgres;Password=2995";
        }

        // Глобальная точка доступа
        public static ConnectionStringProvider Instance => _instance.Value;
    }
}
