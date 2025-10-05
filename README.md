
Refactoring av kodanalysverktyg i C# med fokus p� att f�rb�ttra l�sbarhet och underh�llbarhet.
Student: Aygen

Analys av befintlig kod

C#-applikationen i repot analysrat.
Koden inneh�ller flera brister som p�verkar l�sbarhet, struktur och underh�llbarhet �ven om koden fungerar.
Dessa brister beh�ver �tg�rdas f�r att f�rb�ttra kodkvaliteten.
Identifierade problem

1. Otydliga variabel- och metodnamn

Exempel: unicornSparkle, magicConstant, celestialWhispers
Och namnen beskriver inte vad variabeln g�r, vilket bryter mot principen self-documenting code.
Koden blir sv�r att f�rst� och underh�lla.
F�r l�sning: Jag bytte till mer beskrivande namn som userChoice, userCount, users.

Replace array with List
Bytte till List<string> ist�llet f�r fast array, vilket f�rb�ttrar flexibilitet och skalbarhet.

2. Duplicerad kod

B�de vid borttagning och s�kning anv�nds liknande loopar f�r att hitta anv�ndare.
?Bryter mot DRY (Don�t Repeat Yourself).
Refaktorerade huvudmenyn: ersatte  if/else-satser med en tydlig switch-struktur.
F�rb�ttrar l�sbarhet, enkelhet och underh�llbarhet.

3.Modularized code structure
Delade upp logiken i metoder (AddUser, ShowUsers, RemoveUser, SearchUser) och anv�nde switch i st�llet f�r flera if/else

F�rslag p� f�rb�ttringar:

Lagra listan i fil f�r att beh�lla data mellan k�rningar.(Spara anv�ndare i fil))

Skapa UserManager f�r att separera logik fr�n gr�nssnittet.(Klasser)

Anv�nda try/catch f�r att hantera ogiltiga inmatningar (Felhantering)

**Dessa f�r�ndringar g�r koden mer robust, l�ttare att underh�lla och enklare att testa.

**Reflektion**

Under arbetet l�rde jag mig hur viktigt det �r med tydliga namn och bra kodstruktur. 
Refaktoriseringen gjorde koden mer l�sbar, flexibel och l�tt att underh�lla.
Projektet har gett mig b�ttre f�rst�else f�r att analysera och strukturera kod.