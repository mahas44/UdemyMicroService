namespace FreeCourse.Shared.Constants
{
    public struct SharedConstants
    {
        public const string IdentityServerUrl = "IdentityServerUrl";
        public const string ClientIdForEveryOne = "WebMvcClient";
        public const string ClientIdForUser = "WebMvcClientForUser";
        public struct ApiResources
        {
            public const string Catalog = "resource_catalog";
            public const string PhotoStock = "resource_photo_stock";
            public const string Basket = "resource_basket";
            public const string Discount = "resource_discount";
            public const string Order = "resource_order";
            public const string Payment = "resource_payment";
            public const string Gateway = "resource_gateway";
        }

        public class Scopes
        {
            public const string CatalogFullPermission = "catalog_fullpermission";
            public const string PhotoStockFullPermission = "photo_stock_fullpermission";
            public const string BasketFullPermission = "basket_fullpermission";
            public const string DiscountFullPermission = "discount_fullpermission";
            public const string OrderFullPermission = "order_fullpermission";
            public const string PaymentFullPermission = "payment_fullpermission";
            public const string GatewayFullPermission = "gateway_fullpermission";
            public const string OpenId = "openid";
        }

        public struct TokenExchange
        {
             public const string SubjectTokenType = "urn:ietf:params:oauth:token-type:access_token";
        }
    }
}
