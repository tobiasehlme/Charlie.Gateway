# Charlie.Gateway

# Team Charlie


## Links

Figge:
- [Charlie.Customer.API](https://github.com/FiggeAhlberg/Charlie.Customer.API)
- [Charlie.Customer](https://github.com/FiggeAhlberg/Charlie.Customer)

Philip:
- [Charlie.Product.API](https://github.com/MrFrolin/Charlie.Product.API)
- [Charlie.Product](https://github.com/MrFrolin/Charlie.Product)
  
Anton:

- [Charlie.Order.API](https://github.com/AntonMalm/Charlie.Order.API)
- [Charlie.Order](https://github.com/AntonMalm/Charlie.Order)

Tobias

- [Charlie.Payment](https://github.com/tobiasehlme/Charlie.Payment)

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
  **Downstream Service:** `http://localhost:5000/api/products`

- **GET /products/{id}**  
  **Description:** Retrieves a product by ID.  
  **Downstream Service:** `http://localhost:5000/api/products/{id}`


### Orders

- **POST /orders**  
  **Description:** Creates a new order.  
  **Downstream Service:** `http://localhost:5000/api/orders`

- **GET /orders/{id}**  
  **Description:** Retrieves an order by ID.  
  **Downstream Service:** `http://localhost:5000/api/orders/{id}`


### Customers

- **POST /customers**  
  **Description:** Creates a new customer.  
  **Downstream Service:** `http://localhost:5000/api/customers`

- **GET /customers/{id}**  
  **Description:** Retrieves a customer by ID.  
  **Downstream Service:** `http://localhost:5000/api/customers/{id}`


### Payments

- **POST /payments**  
  **Description:** Creates a new payment.  
  **Downstream Service:** `http://localhost:5000/api/payments`

- **GET /payments/{id}**  
  **Description:** Retrieves a payment by ID.  
  **Downstream Service:** `http://localhost:5000/api/payments/{id}`

