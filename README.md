## Dlaczego merge nie był typu fast-forward?
Operacja nie mogła być wykonana jako fast-forward, ponieważ gałaź main ruszyła do przodu w czasie, gdy pracowałem na feature-max. Historia przestała być liniowa ,oba branche miały unikalne commity, których nie było na drugim. Git musiał stworzyć nowy merge commit, aby połączyć te dwie niezalezne scieżki w jedną.

## Czym się różni merge od rebase ? 
Merge tworzy nowy commit łączący dwie galezie , przez co w historii mamy nieliniowy kształt z rozgałęzieniami. Rebase natomiast przenosi commity na czubek gałęzi docelowej , co skutkuje prostą i przejrzystą linią czasu bez dodatkowych commitow scalających. Rebase dodatkowo przepisuje historię wiec zmeinia id commitów , przez co teoretycznie jest mniej bezpieczną opcją niż merge.

