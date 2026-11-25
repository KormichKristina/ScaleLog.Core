SELECT 
    sc.name as Name,
    sc.species as Species,
    sc.morph as Morph,
    sc.dateOfBirth as DateOfBirth,
    sc.card_created as CardCreated,
    g.name AS Gender
FROM snake_cards sc
LEFT JOIN gender g ON sc.gender_id = g.id
WHERE sc.id = @Id;