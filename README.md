
Refactoring av kodanalysverktyg i C# med fokus på att förbättra läsbarhet och underhållbarhet.
Student: Aygen

Analys av befintlig kod

C#-applikationen i repot analysrat.
Koden innehåller flera brister som påverkar läsbarhet, struktur och underhållbarhet även om koden fungerar.
Dessa brister behöver åtgärdas för att förbättra kodkvaliteten.
Identifierade problem

1. Otydliga variabel- och metodnamn

Exempel: unicornSparkle, magicConstant, celestialWhispers
Och namnen beskriver inte vad variabeln gör, vilket bryter mot principen self-documenting code.
Koden blir svår att förstå och underhålla.
För lösning: Jag bytte till mer beskrivande namn som userChoice, userCount, users.

Replace array with List
Bytte till List<string> istället för fast array, vilket förbättrar flexibilitet och skalbarhet.

2. Duplicerad kod

Både vid borttagning och sökning används liknande loopar för att hitta användare.
?Bryter mot DRY (Don’t Repeat Yourself).
Refaktorerade huvudmenyn: ersatte  if/else-satser med en tydlig switch-struktur.
Förbättrar läsbarhet, enkelhet och underhållbarhet.

3.Modularized code structure
Delade upp logiken i metoder (AddUser, ShowUsers, RemoveUser, SearchUser) och använde switch i stället för flera if/else

Förslag på förbättringar:

Lagra listan i fil för att behålla data mellan körningar.(Spara användare i fil))

Skapa UserManager för att separera logik från gränssnittet.(Klasser)

Använda try/catch för att hantera ogiltiga inmatningar (Felhantering)

**Dessa förändringar gör koden mer robust, lättare att underhålla och enklare att testa.

**Reflektion**

Under arbetet lärde jag mig hur viktigt det är med tydliga namn och bra kodstruktur. 
Refaktoriseringen gjorde koden mer läsbar, flexibel och lätt att underhålla.
Projektet har gett mig bättre förståelse för att analysera och strukturera kod.