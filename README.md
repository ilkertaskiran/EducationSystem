# Education System

Education system project includes that 1 WebAPI project and 1 React SPA project.

## Installation

Use the docker console to create education database.

```bash
docker run --name education-db -e POSTGRES_PASSWORD=edu123 -d -p 5432:5432 -v $HOME/docker/volumes/postgres:/var/lib/postgresql/data postgres


```

## Data Scripts - DML
```bash
INSERT INTO public."Education"
("Id", "Name", "StartDate", "EndDate", "CreatedTime", "UpdatedTime", "IsPublished")
VALUES(1, 'Java', '2023-01-07 23:34:57.686', '2023-01-07 23:34:57.686', '2023-01-07 23:34:57.686', '2023-01-07 23:34:57.687', false);
INSERT INTO public."Education"
("Id", "Name", "StartDate", "EndDate", "CreatedTime", "UpdatedTime", "IsPublished")
VALUES(2, 'HTML', '2023-01-07 21:32:35.925', '2023-01-07 21:32:35.925', '2023-01-07 21:32:35.925', '2023-01-07 21:32:35.925', false);
INSERT INTO public."Education"
("Id", "Name", "StartDate", "EndDate", "CreatedTime", "UpdatedTime", "IsPublished")
VALUES(3, '.NET', '2023-01-07 21:48:57.631', '2023-01-07 21:48:57.631', '2023-01-07 21:48:57.631', '2023-01-07 21:48:57.631', true);


INSERT INTO public."SubEducation"
("Id", "EducationId", "Name", "Description", "Url", "CreatedTime", "UpdatedTime")
VALUES(4, 1, 'Java Lesson 1 ', 'Java Education', 'https://www.youtube.com/watch?v=eZu3IUN1hAI', '2023-01-07 21:48:57.631', '2023-01-07 21:48:57.631');
INSERT INTO public."SubEducation"
("Id", "EducationId", "Name", "Description", "Url", "CreatedTime", "UpdatedTime")
VALUES(5, 1, 'Java Lesson 2', 'Java Education', 'https://www.youtube.com/watch?v=eZu3IUN1hAI', '2023-01-07 21:48:57.631', '2023-01-07 21:48:57.631');
INSERT INTO public."SubEducation"
("Id", "EducationId", "Name", "Description", "Url", "CreatedTime", "UpdatedTime")
VALUES(8, 2, 'HTML Lesson 1', 'Html Education', 'https://www.youtube.com/watch?v=eZu3IUN1hAI', '2023-01-07 21:48:57.631', '2023-01-07 21:48:57.631');
INSERT INTO public."SubEducation"
("Id", "EducationId", "Name", "Description", "Url", "CreatedTime", "UpdatedTime")
VALUES(9, 2, 'HTML Lesson 1', 'Html Education', 'https://www.youtube.com/watch?v=eZu3IUN1hAI', '2023-01-07 21:48:57.631', '2023-01-07 21:48:57.631');
INSERT INTO public."SubEducation"
("Id", "EducationId", "Name", "Description", "Url", "CreatedTime", "UpdatedTime")
VALUES(6, 3, '.NET Lesson 1', '.NET Education', 'https://www.youtube.com/watch?v=eZu3IUN1hAI', '2023-01-07 21:48:57.631', '2023-01-07 21:48:57.631');
INSERT INTO public."SubEducation"
("Id", "EducationId", "Name", "Description", "Url", "CreatedTime", "UpdatedTime")
VALUES(7, 3, '.NET Lesson 2', '.NET Education', 'https://www.youtube.com/watch?v=eZu3IUN1hAI', '2023-01-07 21:48:57.631', '2023-01-07 21:48:57.631');
INSERT INTO public."SubEducation"
("Id", "EducationId", "Name", "Description", "Url", "CreatedTime", "UpdatedTime")
VALUES(10, 1, '.NET Lesson 2', '.NET Education', 'https://www.youtube.com/watch?v=eZu3IUN1hAI', '2023-01-07 21:48:57.631', '2023-01-07 21:48:57.631');

```

