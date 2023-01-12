select * from livre where auteur = 'agatha christie' -- or auteur = 'agatha christies'

UPDATE livre
SET auteur = 'agatha christie'
WHERE auteur = 'agatha christies';

select * from livre where auteur = 'agatha christie'