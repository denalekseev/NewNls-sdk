using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NewNlsSdk.DataContracts
{
    [DataContract]
    public class ReceiptResponse
    {
        /// <summary>
        /// true - истина, false - ошибка
        /// </summary>
        /// <value>true - истина, false - ошибка</value>
        [DataMember(Name = "isSuccess", EmitDefaultValue = false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// Сообщение ошибки
        /// </summary>
        /// <value>Сообщение ошибки</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }
    }
}
