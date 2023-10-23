class Card // 1 classe (composant) par fichier
{
    constructor(_cardFromJson)
    {
        Object.assign(this, _cardFromJson);
    }
}

export { Card }
