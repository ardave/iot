using System;
using System.Device.I2c;
using System.Device.Model;

namespace Iot.Device.Lsm6Ds33
{
    /// <summary>
    /// LSM6DS33 Accelerometer
    /// </summary>
    [Interface("LSM6DS33 Accelerometer")]
    public class Lsm6Ds33Accelerometer
    {
        private readonly I2cDevice _i2CDevice;

        /// <summary>
        /// Initializes a new instance of the <see cref="Lsm6Ds33Accelerometer"/> class.
        /// </summary>
        /// <param name="i2CDevice">The I2CDevice used by this instance.</param>
        public Lsm6Ds33Accelerometer(I2cDevice i2CDevice)
        {
            _i2CDevice = i2CDevice ?? throw new ArgumentNullException(nameof(i2CDevice));
        }
    }
}
