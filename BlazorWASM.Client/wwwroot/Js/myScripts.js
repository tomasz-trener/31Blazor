function calculateSum() {
    // Pobieranie wartości z inputów
    const num1 = parseFloat(document.getElementById("number1").value) || 0;
    const num2 = parseFloat(document.getElementById("number2").value) || 0;

    // Obliczenie sumy
    const result = num1 + num2;

    // Wyświetlenie wyniku w sekcji wyników
    document.getElementById("result").innerHTML = `<strong>Wynik:</strong> ${result}`;
}