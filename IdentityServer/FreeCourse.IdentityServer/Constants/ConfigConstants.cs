namespace FreeCourse.IdentityServer.Constants
{
    public static class ConfigConstants
    {
        public const string Secret = "secret";
        public const string ClientName = "ASP.Net Core MVC";
        public const string ClientIdForEveryOne = "WebMvcClient";
        public const string ClientIdForUser = "WebMvcClientForUser";
        public class ApiResources
        {
            public const string Catalog = "resource_catalog";
            public const string PhotoStock = "resource_photo_stock";
            public const string Basket = "resource_basket";
            public const string Discount = "resource_discount";
            public const string Order = "resource_order";
            public const string Payment = "resource_payment";
        }

        public class Scopes
        {
            public const string CatalogFullPermission = "catalog_fullpermission";
            public const string PhotoStockFullPermission = "photo_stock_fullpermission";
            public const string BasketFullPermission = "basket_fullpermission";
            public const string DiscountFullPermission = "dicount_fullpermission";
            public const string OrderFullPermission = "order_fullpermission";
            public const string PaymentFullPermission = "payment_fullpermission";
        }

        public class ScopeMessages
        {
            public const string CatalogFullPermissionMsg = "Catalog API için full erişim";
            public const string PhotoStockFullPermissionMsg = "PhotoStock API için full erişim";
            public const string BasketFullPermissionMsg = "Basket API için full erişim";
            public const string DiscountFullPermissionMsg = "Dicount API için full erişim";
            public const string OrderFullPermissionMsg = "Order API için full erişim";
            public const string PaymentFullPermissionMsg = "Payment API için full erişim";
        }

        public class CustomIdentityResource
        {
            public const string Name = "roles";
            public const string DisplayName = "Roles";
            public const string Description = "User roles";
            public const string Claim = "role";
        }

        
    }
}
