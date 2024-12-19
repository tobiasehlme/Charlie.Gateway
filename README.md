# Charlie.Gateway

# API Documentation for Charlie.Gateway (Ocelot Gateway)

This document provides an overview of the API routes configured in the Ocelot gateway.

## Base URL
All routes are prefixed with the following base URL:

```
http://localhost:5000
```

## Routes

### Products

- **POST /products**  
  **Description:** Creates a new product.  
  **Downstream Service:** `http://charlie/api/products`

- **GET /products/{id}**  
  **Description:** Retrieves a product by ID.  
  **Downstream Service:** `http://charlie/api/products/{id}`


### Orders

- **POST /orders**  
  **Description:** Creates a new order.  
  **Downstream Service:** `http://charlie/api/orders`

- **GET /orders/{id}**  
  **Description:** Retrieves an order by ID.  
  **Downstream Service:** `http://charlie/api/orders/{id}`


### Customers

- **POST /customers**  
  **Description:** Creates a new customer.  
  **Downstream Service:** `http://charlie/api/customers`

- **GET /customers/{id}**  
  **Description:** Retrieves a customer by ID.  
  **Downstream Service:** `http://charlie/api/customers/{id}`


### Payments

- **POST /payments**  
  **Description:** Creates a new payment.  
  **Downstream Service:** `http://charlie/api/payments`

- **GET /payments/{id}**  
  **Description:** Retrieves a payment by ID.  
  **Downstream Service:** `http://charlie/api/payments/{id}`
