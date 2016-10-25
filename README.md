# AndroidVibrateController
This Unity package provides additional functionality for controlling the
vibrator hardware on an android device.
The package extends Unity to provide the following features:
- Query for the presence of vibrator hardware
- Cause the vibrator to vibrate for a specified amount of time
- Cause the vibrator to vibrate with a specified pattern
- Cancel all currently running vibrations
- Stub functionality for all features, allowing the same code to be run
on non-Android platforms without causing issues

All Android and Unity source code is provided, as well as a package for
Unity.

To use this functionality in Unity, simply import the scripts and plugin
from the package. Next use the static methods of the VibrateController
object to call the desired methods. The VibrateController uses a
"lazy-instantiation" model, similar to a singleton, allowing this object
to be used most anywhere without additional setup. The package also
includes a "VibrateTestScene" and "VibrateTest" script file which should
act as an example of how to use the system.

Using this system on non-Adroid platforms, or Android platforms without
vibrator hardware should not cause issues, but obviously will not
provide vibrator controls in these situations.
