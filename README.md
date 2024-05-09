# MegaventoryCart

# MegaventoryCart API Documentation

# Overview

The MegaventoryCart API provides endpoints for creating/updating products, suppliers, clients, inventory locations and product-client, product-supplier relationships.

# Endpoints

# Product Controller

/product
Description: Endpoint for managing products.
Methods: POST
Request Body: ProductResult
Response: Returns the result of the product update operation.

# Product Supplier Controller

/productsupplier
Description: Endpoint for managing relationships between products and suppliers.
Methods: POST
Request Body: ProductSupplierRelationshipResult
Response: Returns the result of the product-supplier relationship update operation.

# Product Client Controller

/productclient
Description: Endpoint for managing relationships between products and clients.
Methods: POST
Request Body: ProductClientRelationshipResult
Response: Returns the result of the product-client relationship update operation.

# Supplier Client Controller

/supplierclient
Description: Endpoint for managing suppliers and clients.
Methods: POST
Request Body: SupplierClientResult
Response: Returns the result of the supplier-client update operation.

# Inventory Location Controller

/inventorylocation
Description: Endpoint for managing inventory locations.
Methods: POST
Request Body: InventoryLocationResult
Response: Returns the result of the inventory location update operation.

# Inventory Location Stock Controller

/inventorylocationstock
Description: Endpoint for managing inventory location stocks.
Methods: POST
Request Body: InventoryLocationStockResult
Response: Returns the result of the inventory location stock update operation.


# how it relates to a project from your CV (if any)

Almost all code I implemented in this project is related to project from CV (instead of GIT), it includes next:

Creating WebAPI:
  - Creating Models/Entities
  - Creating Controllers
  - Creation, registration of services and constructor injection (Dependency injection)
  - Adding global consts to appsettings.json and using them through IConfiguration service
  - Usage of Swagger for API testing


