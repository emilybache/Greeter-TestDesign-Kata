plugins {
    kotlin("jvm") version "2.2.0"
}

group = "org.sammancoaching"
version = "1.0-SNAPSHOT"

repositories {
    mavenCentral()
}

dependencies {
    testImplementation(kotlin("test"))
    testImplementation("org.mockito.kotlin:mockito-kotlin:5.4.0")
    // https://mvnrepository.com/artifact/org.mockito/mockito-core
    //testImplementation("org.mockito:mockito-core:2.1.0")
    //testImplementation("org.mockito:mockito-kotlin:6.0.0")
}

tasks.test {
    useJUnitPlatform()
}
kotlin {
    jvmToolchain(22)
}