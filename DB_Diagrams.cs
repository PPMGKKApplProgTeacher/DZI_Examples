Разгледайте посояените диаграми на БД и отговорете на следните въпроси:
Кой атрибут е първичен ключ?
Кой атрибут е външен ключ?
Какъв е типът на релацията между таблици A и B?
Може ли да има дублиращи се стойности в атрибут X?
Колко таблици участват в релацията?
Какви аномалии могат да възникнат?


✅ Диаграма 1

Таблица: Student
  - StudentID (int, PK)
  - Name (varchar)
  - GroupID (int, FK към Group)

Таблица: Group
  - GroupID (int, PK)
  - GroupName (varchar)

✅ Диаграма 2

Таблица: Book
  - BookID (int, PK)
  - Title (varchar)
  - AuthorID (int, FK към Author)

Таблица: Author
  - AuthorID (int, PK)
  - Name (varchar)

✅ Диаграма 3

Таблица: Employee
  - EmployeeID (int, PK)
  - Name (varchar)
  - ManagerID (int, FK към Employee)

✅ Диаграма 4

Таблица: Product
  - ProductID (int, PK)
  - Name (varchar)
  - Price (decimal)

Таблица: Category
  - CategoryID (int, PK)
  - Name (varchar)

Таблица: ProductCategory
  - ProductID (int, FK към Product)
  - CategoryID (int, FK към Category)

✅ Диаграма 5

Таблица: Patient
  - PatientID (int, PK)
  - Name (varchar)

Таблица: Appointment
  - AppointmentID (int, PK)
  - PatientID (int, FK към Patient)
  - Date (datetime)

✅ Диаграма 6

Таблица: Course
  - CourseID (int, PK)
  - Title (varchar)

Таблица: Teacher
  - TeacherID (int, PK)
  - Name (varchar)

Таблица: CourseTeacher
  - CourseID (int, FK към Course)
  - TeacherID (int, FK към Teacher)

✅ Диаграма 7

Таблица: Car
  - CarID (int, PK)
  - LicensePlate (varchar)
  - OwnerID (int, FK към Person)

Таблица: Person
  - PersonID (int, PK)
  - Name (varchar)

✅ Диаграма 8

Таблица: User
  - UserID (int, PK)
  - Email (varchar)

Таблица: LoginHistory
  - LoginID (int, PK)
  - UserID (int, FK към User)
  - LoginTime (datetime)

✅ Диаграма 9

Таблица: Movie
  - MovieID (int, PK)
  - Title (varchar)

Таблица: Actor
  - ActorID (int, PK)
  - Name (varchar)

Таблица: MovieActor
  - MovieID (int, FK към Movie)
  - ActorID (int, FK към Actor)

✅ Диаграма 10

Таблица: Order
  - OrderID (int, PK)
  - CustomerID (int, FK към Customer)

Таблица: Customer
  - CustomerID (int, PK)
  - Name (varchar)

✅ Диаграма 11

Таблица: Library
  - LibraryID (int, PK)
  - Name (varchar)

Таблица: BookCopy
  - CopyID (int, PK)
  - BookID (int, FK към Book)
  - LibraryID (int, FK към Library)

Таблица: Book
  - BookID (int, PK)
  - Title (varchar)

✅ Диаграма 12

Таблица: Supplier
  - SupplierID (int, PK)
  - Name (varchar)

Таблица: Product
  - ProductID (int, PK)
  - SupplierID (int, FK към Supplier)
  - Price (decimal)

✅ Диаграма 13

Таблица: Student
  - StudentID (int, PK)
  - Name (varchar)

Таблица: Exam
  - ExamID (int, PK)
  - Subject (varchar)

Таблица: StudentExam
  - StudentID (int, FK към Student)
  - ExamID (int, FK към Exam)
  - Grade (int)

✅ Диаграма 14

Таблица: BlogPost
  - PostID (int, PK)
  - Title (varchar)

Таблица: Comment
  - CommentID (int, PK)
  - PostID (int, FK към BlogPost)
  - Text (varchar)

✅ Диаграма 15

Таблица: City
  - CityID (int, PK)
  - Name (varchar)
  - CountryID (int, FK към Country)

Таблица: Country
  - CountryID (int, PK)
  - Name (varchar)

✅ Диаграма 16

Таблица: File
  - FileID (int, PK)
  - FileName (varchar)
  - FolderID (int, FK към Folder)

Таблица: Folder
  - FolderID (int, PK)
  - ParentID (int, FK към Folder)

✅ Диаграма 17

Таблица: Invoice
  - InvoiceID (int, PK)
  - Date (datetime)

Таблица: InvoiceItem
  - ItemID (int, PK)
  - InvoiceID (int, FK към Invoice)
  - ProductName (varchar)

✅ Диаграма 18

Таблица: Team
  - TeamID (int, PK)
  - Name (varchar)

Таблица: Player
  - PlayerID (int, PK)
  - TeamID (int, FK към Team)
  - Name (varchar)

✅ Диаграма 19

Таблица: Hotel
  - HotelID (int, PK)
  - Name (varchar)

Таблица: Room
  - RoomID (int, PK)
  - HotelID (int, FK към Hotel)
  - RoomNumber (int)

✅ Диаграма 20

Таблица: Product
  - ProductID (int, PK)
  - Name (varchar)

Таблица: Discount
  - DiscountID (int, PK)
  - Description (varchar)

Таблица: ProductDiscount
  - ProductID (int, FK към Product)
  - DiscountID (int, FK към Discount)
