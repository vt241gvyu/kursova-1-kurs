# Issues для лабораторної роботи

Цей файл містить 3 проблеми, які я знайшов у коді курсового проєкту FootballMatch.
Проблеми не вигадані, вони реально є в коді і підходять для теми "Запахи коду".

## Issue 1: Схема бази даних створюється у TournamentsForm

### Проблема

У формі `TournamentsForm` під час завантаження турнірів виконується SQL-код для створення таблиць.
На мою думку, форма не повинна створювати таблиці в базі даних.
Для цього вже є окремий клас `DB`.

### Де знаходиться

- [FootballMatch/TournamentsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TournamentsForm.cs#L16-L26)
- [FootballMatch/DB.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/DB.cs#L12-L28)

### Чому це проблема

Це порушує принцип Single Responsibility Principle.
Форма має відповідати за показ турнірів, а клас `DB` має відповідати за базу даних.
Також через це SQL-код для таблиць частково дублюється.

### Очікуване виправлення

Прибрати створення таблиць з `TournamentsForm`.
Залишити створення таблиць у методі `DB.CreateDB`.

## Issue 2: Оновлення рахунку залежить від тексту в ListBox

### Проблема

У `TournamentDetailsForm` матчі додаються в `ListBox` як звичайний текст.
Потім при оновленні рахунку програма розбирає цей текст назад, щоб отримати команди і дату.

### Де знаходиться

- [FootballMatch/TournamentDetailsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TournamentDetailsForm.cs#L62-L70)
- [FootballMatch/TournamentDetailsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TournamentDetailsForm.cs#L116-L146)

### Чому це проблема

Це крихкий код.
Якщо змінити формат тексту в `ListBox`, оновлення рахунку може перестати працювати.
Також проблема може бути, якщо назва команди містить пробіли.
Це порушує принцип KISS, бо логіка стає складнішою, ніж потрібно.

### Очікуване виправлення

Зберігати разом з текстом ще й `id` матчу.
Оновлювати рахунок по `id`, а не через розбір текстового рядка.

## Issue 3: Поля назв приймають пробіли як нормальне значення

### Проблема

У деяких формах перевірка зроблена через `Text == ""`.
Через це користувач може ввести тільки пробіли, і програма все одно прийме це як правильну назву.

### Де знаходиться

- [FootballMatch/AddTeamForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddTeamForm.cs#L16-L26)
- [FootballMatch/AddTournamentForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddTournamentForm.cs#L16-L26)
- [FootballMatch/TeamDetailsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TeamDetailsForm.cs#L47-L58)
- [FootballMatch/TournamentDetailsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TournamentDetailsForm.cs#L158-L175)

### Чому це проблема

Це слабка валідація даних.
У базу можуть потрапити порожні або майже порожні назви.
Це порушує принцип Fail Fast, бо програма має одразу відхиляти неправильне введення.

### Очікуване виправлення

Перед перевіркою використати `Trim()`.
Якщо після `Trim()` рядок порожній, не дозволяти збереження.
У базу записувати вже очищене значення.
