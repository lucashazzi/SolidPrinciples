
enum Status
{
    Open,
    InProgress,
    Completed,
    Canceled
}

static class StatusExtensions
{
    public static Status SetInProgress(this Status _) => Status.InProgress;
    public static Status SetCompleted(this Status _) => Status.Completed;
    public static Status SetCanceled(this Status _) => Status.Canceled;


}