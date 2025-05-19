// генерирайте UML диаграми за следните класове:

1.

class Book {
    private string title;
    private string author;
    private int pages;
    private double price;
    public void read() {}
    public void bookmarkPage(int page) {}
}

2.

class Student {
    private string name;
    private int studentID;
    private double gpa;
    public void enroll(string courseName) {}
    public void drop(string courseName) {}
}

3.

class Teacher {
    private string name;
    private string department;
    private List<string> courses;
    public void assignCourse(string course) {}
    public void evaluate(Student student) {}
}

4.

class BankAccount {
    private string accountNumber;
    private double balance;
    private string owner;
    public void deposit(double amount) {}
    public void withdraw(double amount) {}
    public double getBalance() { return balance; }
}

5.

class Library {
    private string name;
    private string location;
    private List<Book> books;
    public void addBook(Book b) {}
    public void removeBook(Book b) {}
}

6.

class Rectangle {
    private double width;
    private double height;
    public double calculateArea() { return width * height; }
    public double calculatePerimeter() { return 2 * (width + height); }
}

7.

class Circle {
    private double radius;
    public double calculateArea() { return Math.PI * radius * radius; }
    public double calculateCircumference() { return 2 * Math.PI * radius; }
}

8.

class Employee {
    private string name;
    private int id;
    private double salary;
    public void promote() {}
    public void calculateBonus() {}
}

9.

class Order {
    private int orderID;
    private DateTime orderDate;
    private List<Product> products;
    public void addProduct(Product p) {}
    public void calculateTotal() {}
}

10.

class Product {
    private string name;
    private double price;
    private int quantity;
    public double getTotalPrice() { return price * quantity; }
}

11.

class Flight {
    private string flightNumber;
    private string origin;
    private string destination;
    private DateTime departureTime;
    public void delayFlight(int minutes) {}
    public void cancelFlight() {}
}

12.

class Ticket {
    private int ticketID;
    private string passengerName;
    private Flight flight;
    public void printTicket() {}
}

13.

class Calculator {
    public int add(int a, int b) { return a + b; }
    public int subtract(int a, int b) { return a - b; }
    public int multiply(int a, int b) { return a * b; }
    public double divide(double a, double b) { return a / b; }
}

14.

class Game {
    private string title;
    private string genre;
    private double rating;
    public void startGame() {}
    public void endGame() {}
}

15.

class User {
    private string username;
    private string password;
    private string email;
    public void login() {}
    public void logout() {}
}

16.

class ChatMessage {
    private string sender;
    private string recipient;
    private string messageText;
    private DateTime timestamp;
    public void send() {}
    public void delete() {}
}

17.

class Playlist {
    private string name;
    private List<string> songs;
    public void addSong(string song) {}
    public void removeSong(string song) {}
}

18.

class CarRental {
    private string companyName;
    private List<Car> availableCars;
    public void rentCar(Car c) {}
    public void returnCar(Car c) {}
}

19.

class Address {
    private string street;
    private string city;
    private string postalCode;
    public string getFullAddress() { return street + ", " + city + " " + postalCode; }
}

20.

class Invoice {
    private int invoiceNumber;
    private DateTime dateIssued;
    private List<Product> items;
    private string customerName;
    public void addItem(Product item) {}
    public void printInvoice() {}
}
