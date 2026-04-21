using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NewNlsSdk.DataContracts
{
    [DataContract]
    public class GetStatusesOperationObject
    {
        /// <summary>
        /// true - истина, false - ошибка
        /// </summary>
        /// <value>true - истина, false - ошибка</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Сообщение ошибки
        /// </summary>
        /// <value>Сообщение ошибки</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }
    }
}
