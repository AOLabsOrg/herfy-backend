# Herfy Backend API Documentation

This document describes the RESTful APIs for Herfy Backend, focused on handmade and heritage products. All APIs use JSON, are secured with HTTPS, and require JWT for protected endpoints.

## Base URL
`https://api.herfy.com`

## Authentication
Protected APIs require a JWT in the `Authorization` header: `Bearer {token}`.

## APIs

### 1. Register User
- **Endpoint**: `POST /api/users/register`
- **Description**: Create a new client or artisan account.
- **Request Body**:
  ```json
  {
    "name": "string",
    "email": "string",
    "phone": "string",
    "password": "string",
    "role": "client | artisan"
  }
  ```
- **Response (201 Created)**:
  ```json
  {
    "id": "string",
    "name": "string",
    "email": "string",
    "phone": "string",
    "role": "client | artisan",
    "message": "User registered successfully"
  }
  ```

### 2. Login User
- **Endpoint**: `POST /api/users/login`
- **Description**: Authenticate a user and return a JWT.
- **Request Body**:
  ```json
  {
    "email": "string",
    "password": "string"
  }
  ```
- **Response (200 OK)**:
  ```json
  {
    "id": "string",
    "name": "string",
    "email": "string",
    "role": "client | artisan",
    "token": "string"
  }
  ```

### 3. Get User Profile
- **Endpoint**: `GET /api/users/profile`
- **Description**: Retrieve user profile.
- **Headers**: `Authorization: Bearer {token}`
- **Response (200 OK)**:
  ```json
  {
    "id": "string",
    "name": "string",
    "email": "string",
    "phone": "string",
    "role": "client | artisan",
    "bio": "string",
    "profileImage": "string"
  }
  ```

### 4. Update User Profile
- **Endpoint**: `PUT /api/users/profile`
- **Description**: Update user profile.
- **Headers**: `Authorization: Bearer {token}`
- **Request Body**:
  ```json
  {
    "name": "string",
    "phone": "string",
    "bio": "string",
    "profileImage": "string"
  }
  ```
- **Response (200 OK)**:
  ```json
  {
    "message": "Profile updated successfully"
  }
  ```

### 5. Add Product
- **Endpoint**: `POST /api/products`
- **Description**: Artisan adds a product.
- **Headers**: `Authorization: Bearer {token}` (artisan only)
- **Request Body**:
  ```json
  {
    "name": "string",
    "description": "string",
    "price": "number",
    "category": "heritage | other",
    "images": ["string"],
    "artisanStory": "string"
  }
  ```
- **Response (201 Created)**:
  ```json
  {
    "id": "string",
    "name": "string",
    "price": "number",
    "message": "Product added successfully"
  }
  ```

### 6. List Products
- **Endpoint**: `GET /api/products?search={query}&category={heritage|other}&priceMin={number}&priceMax={number}`
- **Description**: List products with filters.
- **Response (200 OK)**:
  ```json
  [
    {
      "id": "string",
      "name": "string",
      "description": "string",
      "price": "number",
      "category": "heritage | other",
      "images": ["string"],
      "artisanId": "string",
      "artisanName": "string",
      "rating": "number"
    }
  ]
  ```

### 7. Get Product Details
- **Endpoint**: `GET /api/products/{id}`
- **Description**: View product details.
- **Response (200 OK)**:
  ```json
  {
    "id": "string",
    "name": "string",
    "description": "string",
    "price": "number",
    "category": "heritage | other",
    "images": ["string"],
    "artisanId": "string",
    "artisanName": "string",
    "artisanStory": "string",
    "rating": "number"
  }
  ```

### 8. Create Order
- **Endpoint**: `POST /api/orders`
- **Description**: Client creates an order for a product.
- **Headers**: `Authorization: Bearer {token}` (client only)
- **Request Body**:
  ```json
  {
    "productId": "string",
    "quantity": "number",
    "paymentMethod": "paymob | cash"
  }
  ```
- **Response (201 Created)**:
  ```json
  {
    "orderId": "string",
    "message": "Order created successfully"
  }
  ```

### 9. List Client Orders
- **Endpoint**: `GET /api/orders`
- **Description**: View client's order history.
- **Headers**: `Authorization: Bearer {token}` (client only)
- **Response (200 OK)**:
  ```json
  [
    {
      "orderId": "string",
      "productId": "string",
      "productName": "string",
      "quantity": "number",
      "totalPrice": "number",
      "status": "pending | completed | cancelled",
      "date": "string"
    }
  ]
  ```

### 10. List Artisan Orders
- **Endpoint**: `GET /api/artisan/orders`
- **Description**: View artisan's orders.
- **Headers**: `Authorization: Bearer {token}` (artisan only)
- **Response (200 OK)**:
  ```json
  [
    {
      "orderId": "string",
      "productId": "string",
      "productName": "string",
      "clientId": "string",
      "clientName": "string",
      "status": "pending | completed | cancelled",
      "date": "string"
    }
  ]
  ```

### 11. Update Order Status
- **Endpoint**: `PUT /api/artisan/orders/{orderId}`
- **Description**: Artisan updates order status.
- **Headers**: `Authorization: Bearer {token}` (artisan only)
- **Request Body**:
  ```json
  {
    "status": "pending | completed | cancelled"
  }
  ```
- **Response (200 OK)**:
  ```json
  {
    "message": "Order status updated successfully"
  }
  ```

### 12. Create Chat
- **Endpoint**: `POST /api/chat`
- **Description**: Start a chat between client and artisan.
- **Headers**: `Authorization: Bearer {token}`
- **Request Body**:
  ```json
  {
    "artisanId": "string"
  }
  ```
- **Response (201 Created)**:
  ```json
  {
    "chatId": "string",
    "message": "Chat created successfully"
  }
  ```

### 13. Send Message
- **Endpoint**: `POST /api/chat/{chatId}/messages`
- **Description**: Send a message in a chat.
- **Headers**: `Authorization: Bearer {token}`
- **Request Body**:
  ```json
  {
    "content": "string"
  }
  ```
- **Response (201 Created)**:
  ```json
  {
    "messageId": "string",
    "content": "string",
    "senderId": "string",
    "timestamp": "string"
  }
  ```

### 14. List Chat Messages
- **Endpoint**: `GET /api/chat/{chatId}/messages`
- **Description**: View chat message history.
- **Headers**: `Authorization: Bearer {token}`
- **Response (200 OK)**:
  ```json
  [
    {
      "messageId": "string",
      "content": "string",
      "senderId": "string",
      "senderName": "string",
      "timestamp": "string"
    }
  ]
  ```

## Testing
Use **Swagger** at `/swagger` or **Postman** to test the APIs locally.

## Notes
- All APIs are documented using Swagger.
- External integrations (e.g., Paymob, Firebase) are handled via SDKs.