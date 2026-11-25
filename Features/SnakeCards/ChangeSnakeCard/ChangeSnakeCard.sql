UPDATE snake_cards
SET 
    name =@Name,
    species = @Species,
    morph = @Morph
WHERE id = @Id;