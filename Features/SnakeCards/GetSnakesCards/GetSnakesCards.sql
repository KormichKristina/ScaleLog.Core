SELECT 
    sc.id as Id,
    sc.name as Name,
    sc.species as Species,
    sc.morph as Morph,
    g.name AS Gender
FROM snake_cards sc
LEFT JOIN gender g ON sc.gender_id = g.id