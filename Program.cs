


using AbstractDemo;

Teacher teacher = new Teacher();
teacher.Display();
Student student = new Student();
student.Display();
Employee employee = new Employee();
employee.Display();
Doctor doctor = new Doctor();
doctor.Display();


Person person;


person = teacher;
doctor.DemoOfReferenceCall(person);

person = student;
doctor.DemoOfReferenceCall(person);


person = employee;
doctor.DemoOfReferenceCall(person);

person = doctor;
doctor.DemoOfReferenceCall(person);

