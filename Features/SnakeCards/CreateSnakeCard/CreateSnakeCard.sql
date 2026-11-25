INSERT INTO snake_cards(name,species,morph,dateOfBirth,gender_id) VALUES
    (@Name,@Species,@Morph,@DateOfBirth, (SELECT id FROM gender WHERE name = @Gender));