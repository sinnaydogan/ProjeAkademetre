BEGIN TRANSACTION;

CREATE TABLE veriler(site char(20), urun char(20), fiyat int);
SELECT * FROM veriler;

INSERT into veriler(site, urun, fiyat) values('Teknosa','Apple iPhone 8 ',600000);
INSERT into veriler(site, urun, fiyat) values('Hepsiburada','Apple iPhone 8 ',612000);
INSERT into veriler(site, urun, fiyat) values('MediaMarkt','Apple iPhone 8 ',586900);
INSERT into veriler(site, urun, fiyat) values('Amazon','Apple iPhone 8 ',600000);
INSERT into veriler(site, urun, fiyat) values('Teknosa','PS 4',399900);
INSERT into veriler(site, urun, fiyat) values('Hepsiburada','PS 4',399900);
INSERT into veriler(site, urun, fiyat) values('MediaMarkt','PS 4',399900);
INSERT into veriler(site, urun, fiyat) values('Amazon','PS 4',385000);
INSERT into veriler(site, urun, fiyat) values('Teknosa','Apple MacBook Pro',1099900);
INSERT into veriler(site, urun, fiyat) values('Hepsiburada','Apple MacBook Pro',1125000);
INSERT into veriler(site, urun, fiyat) values('MediaMarkt','Apple MacBook Pro',1089900);
INSERT into veriler(site, urun, fiyat) values('Amazon','Apple MacBook Pro',1345000);
COMMIT;
			
SELECT urun,MIN([fiyat]) AS 'Minimum Fiyat', MAX([Fiyat]) AS 'Maksimum Fiyat', AVG([fiyat]) AS 'Ortalama Fiyat'
	FROM [veriler]
	GROUP BY urun;


			
			
			