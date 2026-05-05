# Принципи програмування в проєкті FootballMatch

## Encapsulation

Інкапсуляція потрібна для того, щоб клас зберігав свої дані і давав зручний доступ до них через властивості або методи.

У проєкті це видно в класі `User`.

- [FootballMatch/User.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/User.cs#L3-L18)

У цьому класі зберігаються дані користувача: `Id`, `Login`, `Email`, `Role`.

Також є властивість `IsAdmin`, яка перевіряє роль користувача. Завдяки цьому в інших місцях не треба кожен раз напряму порівнювати роль з `"admin"`.

---

## Validation / Fail Fast

Цей принцип означає, що неправильні дані треба перевіряти одразу, до запису в базу або виконання дії.

У проєкті це видно у формі додавання матчу.

- [FootballMatch/AddScheduleForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddScheduleForm.cs#L64-L84)

Перед збереженням матчу перевіряється, чи вибрані турнір і команди.

Також є перевірка, щоб домашня і гостьова команда не були однаковими. Якщо дані неправильні, показується повідомлення і код далі не виконується.

---

## Separation of Concerns

Цей принцип означає, що різні частини програми повинні відповідати за різні задачі.

У Windows Forms це видно через поділ на файл форми і файл Designer.

- [FootballMatch/AddTeamForm.Designer.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddTeamForm.Designer.cs#L14-L52)
- [FootballMatch/AddTeamForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddTeamForm.cs#L13-L32)

У `AddTeamForm.Designer.cs` описані елементи інтерфейсу.

У `AddTeamForm.cs` знаходиться логіка, яка виконується після натискання кнопки. Через це код трохи легше читати і змінювати.

---

## Meaningful Naming

Назви класів і методів повинні бути зрозумілими, щоб по них можна було швидко зрозуміти, що робить код.

У проєкті є нормальні приклади таких назв.

- [FootballMatch/ScheduleForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/ScheduleForm.cs#L19-L28)
- [FootballMatch/HistoryForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/HistoryForm.cs#L16-L29)

Метод `LoadSchedule` завантажує розклад матчів.

Метод `LoadHistory` завантажує історію матчів.

Такі назви не потребують додаткового пояснення.

---

## Parameterized Queries

У SQL-запитах краще використовувати параметри, а не склеювати рядок вручну.

Це зменшує ризик помилок і робить код безпечнішим.

- [FootballMatch/FormSignIn.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/FormSignIn.cs#L30-L32)
- [FootballMatch/AddScheduleForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddScheduleForm.cs#L91-L104)

У формі входу логін і пароль передаються через параметри.

У формі додавання матчу дані матчу також передаються через параметри. Це краще, ніж вставляти значення прямо в SQL-запит.
