# Issues для лабораторної

## Issue 1: Створення таблиць у формі TournamentsForm

### Проблема

У файлі `TournamentsForm.cs` є SQL-запит для створення таблиць. Як на мене, це не дуже правильно, бо форма повинна показувати турніри, а не відповідати за створення бази даних.

Для роботи з базою вже є окремий клас `DB`.

### Де знаходиться

- [FootballMatch/TournamentsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TournamentsForm.cs#L16-L26)
- [FootballMatch/DB.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/DB.cs#L12-L28)

### Чому це проблема

Тут порушується принцип Single Responsibility Principle, бо форма бере на себе зайву відповідальність.

Також частина SQL-логіки повторюється, через що код складніше підтримувати.

### Як виправити

Потрібно прибрати створення таблиць з `TournamentsForm` і залишити цю логіку в класі `DB`.

---

## Issue 2: Оновлення рахунку через текст з ListBox

### Проблема

У `TournamentDetailsForm.cs` матчі додаються в `ListBox` як текстовий рядок. Потім при зміні рахунку цей рядок розбивається назад, щоб дістати назви команд і дату.

Це не дуже надійний варіант, бо програма залежить від формату тексту.

### Де знаходиться

- [FootballMatch/TournamentDetailsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TournamentDetailsForm.cs#L62-L70)
- [FootballMatch/TournamentDetailsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TournamentDetailsForm.cs#L116-L146)

### Чому це проблема

Якщо трохи змінити текст, який показується в `ListBox`, оновлення рахунку може зламатися.

Також можуть бути проблеми, якщо назва команди має пробіли або схожий формат.

Це можна вважати запахом коду, бо логіка залежить від тексту інтерфейсу.

### Як виправити

Краще зберігати для кожного матчу його `id`, а в `ListBox` показувати тільки текст для користувача.

Оновлення рахунку потрібно робити по `id` матчу, а не через розбір рядка.

---

## Issue 3: Можна зберегти назву з одних пробілів

### Проблема

У деяких формах перевірка поля зроблена через `Text == ""`.

Через це користувач може ввести просто пробіли, і програма прийме це як нормальне значення.

### Де знаходиться

- [FootballMatch/AddTeamForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddTeamForm.cs#L16-L26)
- [FootballMatch/AddTournamentForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddTournamentForm.cs#L16-L26)
- [FootballMatch/TeamDetailsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TeamDetailsForm.cs#L47-L58)
- [FootballMatch/TournamentDetailsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TournamentDetailsForm.cs#L158-L175)

### Чому це проблема

У базу можуть потрапити неправильні назви, які візуально виглядають як порожні.

Це слабка валідація даних.

### Як виправити

Перед перевіркою потрібно використовувати `Trim()`.

Якщо після `Trim()` рядок порожній, не дозволяти збереження. У базу краще записувати вже очищений текст.
