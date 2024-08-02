﻿
namespace Ex03.GarageLogic
{
    // $G$ DSN-001 (-10) Code duplication. except in energy type, gas and electric motorcycle are identical.

    public sealed class ElectricMotorcycle : ElectricVehicle
    {
        private eLicenseType m_LicenseType;
        private int m_EngineVolumeInCc;
        private const int k_NumberOfWheels = 2;
        private const int k_MaxAirPressure = 33;

        public ElectricMotorcycle()
        {
            MaxBatteryTimeInHours = 2.5f;
            InitWheelsList(k_NumberOfWheels, k_MaxAirPressure);
        }

        public eLicenseType LicenseType
        {
            get { return m_LicenseType; }
            set { m_LicenseType = value; }
        }

        public int EngineVolumeInCc
        {
            get { return m_EngineVolumeInCc; }
            set
            {
                if(value < 0)
                {
                    throw new ValueOutOfRangeException();
                }

                m_EngineVolumeInCc = value;
            }
        }
    }
}