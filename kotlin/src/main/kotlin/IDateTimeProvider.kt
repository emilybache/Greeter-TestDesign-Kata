import java.time.LocalDateTime

interface IDateTimeProvider {
    fun getDateTime(): LocalDateTime
}