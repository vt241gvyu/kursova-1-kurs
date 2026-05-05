# Принципи програмування в проєкті FootballMatch

Цей файл підготовлений для лабораторної роботи №1 на тему "Принципи програмування. Запахи коду".
Я проаналізував код курсового проєкту FootballMatch і вибрав тільки ті принципи, які реально видно в коді.

## Encapsulation

Encapsulation означає, що клас зберігає свої дані всередині себе і дає іншим частинам програми зручний спосіб з ними працювати.

**Де використано в проєкті:**
- [FootballMatch/User.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/User.cs#L3-L18)

У класі `User` зберігаються дані користувача: `Id`, `Login`, `Email`, `Role`.
Також є властивість `IsAdmin`, яка сама перевіряє, чи є користувач адміністратором.
Завдяки цьому в інших формах не треба кожен раз вручну писати перевірку `Role == "admin"`.

## Fail Fast / Validation

Fail Fast означає, що програма одразу зупиняє дію, якщо користувач ввів неправильні дані.
Це допомагає не записувати некоректну інформацію в базу даних.

**Де використано в проєкті:**
- [FootballMatch/AddScheduleForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddScheduleForm.cs#L64-L84)

У формі додавання матчу спочатку перевіряється, чи вибрані команди і турнір.
Також перевіряється, щоб домашня і гостьова команда не були однаковими.
Якщо дані неправильні, показується повідомлення і метод завершується через `return`.

## Separation of Concerns

Separation of Concerns означає, що різні частини програми мають відповідати за різні задачі.
Наприклад, один файл відповідає за вигляд форми, а інший за логіку кнопок.

**Де використано в проєкті:**
- [FootballMatch/AddTeamForm.Designer.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddTeamForm.Designer.cs#L14-L52)
- [FootballMatch/AddTeamForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddTeamForm.cs#L13-L32)

У `AddTeamForm.Designer.cs` знаходиться код для створення елементів форми: textbox, label, button.
У `AddTeamForm.cs` знаходиться логіка, яка виконується після натискання кнопки збереження.
Це нормальний приклад розділення інтерфейсу і поведінки програми.

## Meaningful Naming

Meaningful Naming означає, що назви класів, методів і змінних мають бути зрозумілими.
Коли назва нормальна, легше читати код без додаткових пояснень.

**Де використано в проєкті:**
- [FootballMatch/ScheduleForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/ScheduleForm.cs#L19-L28)
- [FootballMatch/HistoryForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/HistoryForm.cs#L16-L29)

Метод `LoadSchedule` зрозуміло показує, що він завантажує розклад матчів.
Метод `LoadHistory` показує, що він завантажує історію зіграних матчів.
Такі назви допомагають швидше зрозуміти код.

## Parameterized Queries

Parameterized Queries означає, що дані користувача передаються в SQL-запит через параметри.
Це краще, ніж вручну склеювати SQL-рядок, бо так код безпечніший і простіший для читання.

**Де використано в проєкті:**
- [FootballMatch/FormSignIn.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/FormSignIn.cs#L30-L32)
- [FootballMatch/AddScheduleForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddScheduleForm.cs#L91-L104)

У формі входу логін і пароль передаються через параметри `@uL` і `@uP`.
У формі додавання матчу дані також передаються через параметри: `@tournament`, `@stadium`, `@date`, `@home`, `@away`, `@notes`.
Це хороший приклад більш правильного написання SQL-запитів.
