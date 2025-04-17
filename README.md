# WavefrontMap

A Windows Forms application for calculating and visualizing wavefront maps from Zernike coefficients.

## Features

- Load Zernike coefficients from TXT or HTML files
- Calculate and display wavefront maps
- Support for customizable parameters:
  - Aperture radius
  - Wavelength
  - Resolution
- Display units in waves or micrometers
- Show Peak-to-Valley (PV) and RMS statistics
- Interactive visualization with jet colormap

## Usage

1. Launch the application
2. Set your desired parameters:
   - Aperture Radius (default: 0.0033 meters)
   - Wavelength (default: 6.3e-7 meters)
   - Resolution (default: 256 points)
3. Click "Load Coefficients" to load your Zernike coefficients file
4. Click "Calculate" to generate the wavefront map
5. View the results in the visualization panel and check the statistics

## Input File Formats

### Text File
One coefficient per line:
```
0.00000
0.26930
0.02280
...
```

### HTML File
Table format with coefficient values in td tags:
```html
<table>
<tr><th>0</th><th>Piston</th><td>0.00000</td></tr>
<tr><th>1</th><th>Tilt Y</th><td>0.26930</td></tr>
<tr><th>2</th><th>Tilt X</th><td>0.02280</td></tr>
...
</table>
```

## Requirements

- Windows x64 operating system
- No additional dependencies required (self-contained executable)