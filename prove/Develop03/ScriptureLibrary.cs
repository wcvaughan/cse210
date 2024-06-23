public class ScriptureLibrary
{
    private List<Scripture> _scriptures;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        LoadScriptures();
    }
    private void LoadScriptures()
    {
        _scriptures.Add(new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        _scriptures.Add(new Scripture(new Reference("Moroni", 10, 4, 5), "4 And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.\nAnd by the power of the Holy Ghost ye may know the truth of all things."));
        _scriptures.Add(new Scripture(new Reference("Ether", 12, 6), "6 And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith."));
        _scriptures.Add(new Scripture(new Reference("Helaman", 5, 12), "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."));
        _scriptures.Add(new Scripture(new Reference("Alma", 7, 11, 13), "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.\nAnd he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.\nNow the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me."));
        _scriptures.Add(new Scripture(new Reference("2 Nephi", 32, 8, 9), "And now, my beloved brethren, I perceive that ye ponder still in your hearts; and it grieveth me that I must speak concerning this thing. For if ye would hearken unto the Spirit which teacheth a man to pray, ye would know that ye must pray; for the evil spirit teacheth not a man to pray, but teacheth him that he must not pray.\nBut behold, I say unto you that ye must pray always, and not faint; that ye must not perform any thing unto the Lord save in the first place ye shall pray unto the Father in the name of Christ, that he will consecrate thy performance unto thee, that thy performance may be for the welfare of thy soul."));
        _scriptures.Add(new Scripture(new Reference("Mosiah", 3, 19), "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."));
        _scriptures.Add(new Scripture(new Reference("Alma", 37, 35), " O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God."));
        _scriptures.Add(new Scripture(new Reference("3 Nephi", 12, 48), "Therefore I would that ye should be perfect even as I, or your Father who is in heaven is perfect."));
    }
    public int GetCount()
    {
        return _scriptures.Count();
    }
    public List<Scripture> GetAllScriptures()
    {
        return _scriptures;
    }
}