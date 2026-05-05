# Принципи програмування в проєкті FootballMatch

## Encapsulation

Encapsulation означає, що деталі стану або перевірок ховаються всередині класу, а інший код працює з простішим і зрозумілішим API.

**Де використано в проєкті:**
- [FootballMatch/User.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/User.cs#L3-L18) - клас `User` зберігає дані користувача, а перевірку ролі адміністратора винесено в властивість `IsAdmin`. Інші форми не порівнюють роль напряму, а читають готову ознаку.

## Fail Fast / Validation

Fail Fast означає, що програма одразу зупиняє операцію, якщо вхідні дані неправильні, і не переходить до виконання основної логіки з некоректним станом.

**Де використано в проєкті:**
- [FootballMatch/AddScheduleForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddScheduleForm.cs#L64-L84) - перед створенням матчу форма перевіряє, чи вибрано обидві команди, чи це не одна й та сама команда, і чи вибрано турнір. Якщо дані неправильні, метод показує повідомлення і завершується через `return`.

## Separation of Concerns

Separation of Concerns означає, що різні частини програми відповідають за різні задачі, а не змішують усе в одному місці.

**Де використано в проєкті:**
- [FootballMatch/AddTeamForm.Designer.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddTeamForm.Designer.cs#L14-L52) - Designer-файл відповідає за створення і налаштування елементів форми.
- [FootballMatch/AddTeamForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddTeamForm.cs#L13-L32) - основний файл форми містить логіку обробника кнопки збереження. Це розділяє код інтерфейсу і код поведінки форми.

## Meaningful Naming

Meaningful Naming означає, що назви методів і змінних мають пояснювати їхнє призначення без додаткових коментарів.

**Де використано в проєкті:**
- [FootballMatch/ScheduleForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/ScheduleForm.cs#L19-L28) - метод `LoadSchedule` читається як дія завантаження розкладу матчів.
- [FootballMatch/HistoryForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/HistoryForm.cs#L16-L29) - метод `LoadHistory` одразу показує, що форма завантажує історію зіграних матчів.

## Parameterized Queries

Parameterized Queries допомагають не збирати SQL з рядків користувача вручну. Це робить код безпечнішим і зрозумілішим, бо значення передаються окремо від тексту SQL-запиту.

**Де використано в проєкті:**
- [FootballMatch/FormSignIn.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/FormSignIn.cs#L30-L32) - логін і пароль передаються через параметри `@uL` та `@uP`, а не вставляються напряму в SQL.
- [FootballMatch/AddScheduleForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddScheduleForm.cs#L91-L104) - дані нового матчу додаються через параметри `@tournament`, `@stadium`, `@date`, `@home`, `@away` і `@notes`.
