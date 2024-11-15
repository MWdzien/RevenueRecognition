# RevenueRecognition

I have decided to rewrite the PaymentSystem project as it had a lot of design flaws. The layered architecture
used in the previous version didn't really meet the rules of SOLID as it completely broke the Dependency Inversion
Principle. This project will follow the Clean Architecture rules. I decided to go with the domain driven approach,
additionally implementing CQRS pattern. 
I also decided to separate the Individual Customer from Company Customer and make them inherit basic
attributes from common Customer class.

Project context:
The aim of this project is to create a system responsible for calculation of the company revenue. It faces the problem of when to recognize the payment as part of the company revenue. (For example if the company provides paid services such as selling software for some period of time, it should only recognize the revenue when the payment for the entire period is completed) 

Functional requirements

Customer: 
Storing the information about individual (first name, last name, address, email, phone numer, PESEL) and company (name, address, email, phone number, KRS) customers.

Use cases: 
- Add a customer 
- Delete a customer (only soft delete individual customer) 
- Update customer data (excluding PESEL and KRS numbers)


Software: Software is the product our company is selling, system should store information about the name, description, version and category. Software can be bought with one time payment as well as in form of a subscription. 

Use cases:
- Add software
- Delete software
- Update software data

Discounts:
Discounts are related to a product (software). System should store information about the name, discount rate, beginning and ending date.

Use cases:
- Add discount
- Delete discount

Contracts:
Storing information about software, customer, 