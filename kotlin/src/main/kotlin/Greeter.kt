internal class Greeter(private val dateTimeProvider: IDateTimeProvider) {
    
    fun greet(name: String?): String {
        requireNotNull(name) { "name cannot be null" }
        
        val hour = dateTimeProvider.getDateTime().hour
        val template = when {
            hour in 7..13 -> "Good morning %s"
            hour in 14..19 -> "Good afternoon %s"
            hour in 20..23 || hour in 0..6 -> "Good night %s"
            else -> ""
        }
        return template.format(name)
    }
}