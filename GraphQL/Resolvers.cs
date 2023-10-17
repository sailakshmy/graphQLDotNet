class Resolvers{
    public String GetFormattedDate([Parent]Book e){
        return e.PublishedDate.ToShortDateString();
    }
}