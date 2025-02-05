# Advantages of Encapsulation

## 1. Data Security and Integrity
If we grant direct access to the data, another class or code snippet could modify the data incorrectly. This can lead to data inconsistencies, especially in complex systems. With encapsulation, access to the data is provided only in a controlled manner. This ensures that the data is used correctly and securely.

For example, we could directly change the `name` variable, but the username cannot be set to an empty value. We can prevent this by using a setter method.

![image](https://github.com/user-attachments/assets/f5e8ce24-0c9b-412b-95ab-ffd5daa3432e)

### Advantage:
Encapsulation ensures data integrity. The data can be validated before being modified incorrectly or improperly.

---

## 2. Ease of Maintenance
If data is directly accessible, it can be accessed and modified anywhere in the system. This makes it difficult to understand when, where, and how the data is being changed. However, if access to the data is provided only through methods, when we need to make a change, we only need to modify the method itself. This simplifies maintenance tasks.

For example, when business logic changes, a modification in the `SetName` method will be effective throughout the entire application. However, if direct access is allowed, changes must be made manually in every location.

![image](https://github.com/user-attachments/assets/2773f342-f221-4cf7-aef4-49fe79ea8946)

### Advantage:
Maintenance and extension become easier because data is accessed only through methods, allowing you to manage data changes from a centralized point.

---

## 3. Resilience to Changes
With encapsulation, it becomes easier to change the internal structure of the data. If direct access to the data is allowed, a small change in the data structure could affect the entire codebase. However, with encapsulation, you can make changes by only modifying the methods, without affecting the external code.

For example, if we want to change the type of the `name` variable, by making the data private and providing access through a method, we only need to modify the method itself. However, with direct access, changes would need to be made everywhere, and those changes would have to align with the data type modifications.

![image](https://github.com/user-attachments/assets/8e7bb6d1-0cfd-454a-86e6-d56a2d689a72)

### Advantage:
The code becomes more resilient. Updates can be made as the internal structure changes without affecting the external code.

---

## 4. Controlled Access
Providing access to data only under certain conditions is also an advantage of encapsulation. For example, we might allow the price of a product to be changed through an externally accessible method, but we may want to ensure that the price stays within a specific range.

![image](https://github.com/user-attachments/assets/ac379491-d467-43cd-b26f-ee1b0a14e09f)

### Advantage:
Encapsulation can control access to data and ensure data integrity.
