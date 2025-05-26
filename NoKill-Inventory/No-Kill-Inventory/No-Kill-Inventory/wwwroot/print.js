window.printText = (text) => {
    const printWindow = window.open('', '_blank');
    printWindow.document.write('<pre>' + text + '</pre>');
    printWindow.document.close();
    printWindow.print();
};