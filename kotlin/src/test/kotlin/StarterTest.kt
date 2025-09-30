import org.junit.jupiter.api.Assertions.assertEquals
import org.junit.jupiter.api.Test
import org.mockito.Mockito.mock
import org.mockito.kotlin.whenever

import java.time.LocalDateTime

class StarterTest {

    @Test
    fun goodMorning() {
        val provider = dateTimeWithHour(7)

        val greeter = Greeter(provider)

        assertEquals("Good morning Arnau", greeter.greet("Arnau"))
    }

    @Test
    fun inTheAfternoon() {
        val provider = dateTimeWithHour(16)
        val greeter = Greeter(provider)

        assertEquals("Good afternoon Arnau", greeter.greet("Arnau"))
    }

    @Test
    fun afterTheAfternoon() {
        val provider = dateTimeWithHour(0)
        val greeter = Greeter(provider)

        assertEquals("Good night Arnau", greeter.greet("Arnau"))
    }

    private fun dateTimeWithHour(hour: Int): IDateTimeProvider {
        val provider = mock<IDateTimeProvider>()
        whenever(provider.getDateTime()).thenReturn(LocalDateTime.of(2000, 1, 1, hour, 0, 0))
        return provider
    }
}