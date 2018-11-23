#define RED_LED_PIN 2
#define GREEN_LED_PIN 3
#define BLUE_LED_PIN 4

#define COLOR_RED '0'
#define COLOR_GREEN '1'
#define COLOR_BLUE '2'
#define COLOR_RED_GREEN '3'
#define COLOR_RED_BLUE '4'
#define COLOR_GREEN_BLUE '5'
#define COLOR_RED_GREEN_BLUE '6'

#define TURN_OFF_CHAR '9'

void setup()
{
    Serial.begin(9600);
    pinMode(RED_LED_PIN, OUTPUT);
    pinMode(GREEN_LED_PIN, OUTPUT);
    pinMode(BLUE_LED_PIN, OUTPUT);
}

void loop()
{
    readSerial();
}

void readSerial()
{
    if (Serial.available() > 0)
    {
        char screenResult = Serial.read();

        switch (screenResult)
        {
        case COLOR_RED:
            setColor(1, 0, 0);
            break;
        case COLOR_GREEN:
            setColor(0, 1, 0);
            break;
        case COLOR_BLUE:
            setColor(0, 0, 1);
            break;
        case COLOR_RED_GREEN:
            setColor(1, 1, 0);
            break;
        case COLOR_RED_BLUE:
            setColor(1, 0, 1);
            break;
        case COLOR_GREEN_BLUE:
            setColor(0, 1, 1);
            break;
        case COLOR_RED_GREEN_BLUE:
            setColor(1, 1, 1);
            break;
        case TURN_OFF_CHAR:
            setColor(0, 0, 0);
            break;
        }

        Serial.println("OK");
    }
}

void setColor(bool r, bool g, bool b)
{
    digitalWrite(RED_LED_PIN, r);
    digitalWrite(GREEN_LED_PIN, g);
    digitalWrite(BLUE_LED_PIN, b);
}