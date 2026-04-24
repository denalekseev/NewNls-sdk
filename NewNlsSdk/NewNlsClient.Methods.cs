using NewNlsRemoteClient.Model;
using NewNlsSdk.DataContracts;
using NewNlsSdk.DataContracts.Token;
using RestSharp;
using Restub.Toolbox;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NewNlsSdk
{
    /// <remarks>
    /// NewNls API Client, methods.
    /// </remarks>
    public partial class NewNlsClient
    {
        /// <summary>
        /// Получить токен
        /// </summary>
        public TokenResponse GetToken(string depCode, string login, string password) =>
            Get<TokenResponse>($"/api/v1/Admin/Token", r => AddQueryString(r, new Dictionary<string, object> { { "depCode", depCode }, { "login", login }, { "password", password } }));

        public void AddGetTokenQueryString(IRestRequest initReq, string depCode, string login, string password)
        {
            InitRequest(initReq);

            initReq.AddQueryParameter("depCode", depCode);
            initReq.AddQueryParameter("login", login);
            initReq.AddQueryParameter("password", password);
        }


        /// <summary>
        /// Получает все доступные физические склады(они нужны для создания документа Поставки)
        /// </summary>
        public WareHouseResponse GetWareHouses(string depCode) =>
            Get<WareHouseResponse>($"/api/v1/Receipt/warehouse", r => AddQueryString(r, new Dictionary<string, object> { { "depCode", depCode } }));

        /// <summary>
        /// Получает все доступные статусы 
        /// </summary>
        public GetStatusesResponse GetStatuses() =>
            Get<GetStatusesResponse>($"/api/v1/Receipt/statuses", r => InitAuthRequest(r));

        /// <summary>
        ///Отправить данные для создания документа поставки
        /// </summary>
        public ReceiptResponse CreateReceipt(ReceiptRequest req) =>
            Post<ReceiptResponse>($"/api/v1/Receipt", req, r => InitAuthRequest(r));


        /// <summary>
        /// Получает статус документа поставки
        /// </summary>
        public ReceiptStatusResponse GetReceiptStatus(string depCode, string warehouseCode, string docNumber) =>
            Get<ReceiptStatusResponse>($"/api/v1/Receipt/status", r => AddQueryString(r, new Dictionary<string, object> { { "depCode", depCode }, { "warehouseCode", warehouseCode }, { "docNumber", docNumber } }));

		/// <summary>
		///Отправить данные для создания документа заказа
		/// </summary>
		public OrderResponse CreateOrder(OrderRequest req) =>
			Post<OrderResponse>($"/api/v1/Order", req, r => InitAuthRequest(r));

		/// <summary>
		/// Получает статус документа заказа
		/// </summary>
		public OrderStatusResponse GetOrderStatus(string depCode, string warehouseCode, string docNumber) =>
			Get<OrderStatusResponse>($"/api/v1/Order/status", r => AddQueryString(r, new Dictionary<string, object> { { "depCode", depCode }, { "warehouseCode", warehouseCode }, { "docNumber", docNumber } }));

		/// <summary>
		///Отправить данные для создания документа отгрузки
		/// </summary>
		public OrderResponse CreateShipment(ShipmentRequest req) =>
			Post<OrderResponse>($"/api/v1/Shipment", req, r => InitAuthRequest(r));

		/// <summary>
		///Отмена документа
		/// </summary>
		public DocumentCancelResponse CreateShipment(DocumentCancelRequest req) =>
			Post<DocumentCancelResponse>($"/api/v1/Documents/cancel", req, r => InitAuthRequest(r));


		public void InitRequest(IRestRequest initReq)
        {
            initReq.AddHeader("Content-Type", "application/json");
            initReq.AddHeader("Accept", "application/json");
        }

        public void AddQueryString(IRestRequest initReq, Dictionary<string, object> queryPars)
        {
            InitRequest(initReq);

            if (queryPars != null)
            {
                foreach (var key in queryPars)
                {
                    initReq.AddQueryParameter(key.Key, key.Value.ToString());
                }
            }
        }
    }
}